﻿namespace BundleTransformer.Core.Transformers
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Web;
	using System.Web.Optimization;

	using Assets;
	using Configuration;
	using Minifiers;
	using Resources;
	using Translators;

	/// <summary>
	/// Base class of transformer is responsible for processing assets
	/// </summary>
	public abstract class TransformerBase : IBundleTransform, IDisposable
	{
		/// <summary>
		/// List of patterns of files and directories that 
		/// should be ignored when processing
		/// </summary>
		protected string[] _ignorePatterns;

		/// <summary>
		/// Flag that web application is in debug mode
		/// </summary>
		protected bool _isDebugMode;

		/// <summary>
		/// Configuration settings of core
		/// </summary>
		protected CoreSettings _coreConfig;

		/// <summary>
		/// List of translators (LESS, Sass, SCSS and CoffeeScript)
		/// </summary>
		protected IList<ITranslator> _translators;

		/// <summary>
		/// Minifier
		/// </summary>
		protected IMinifier _minifier;


		/// <summary>
		/// Constructs instance of transformer
		/// </summary>
		/// <param name="ignorePatterns">List of patterns of files and directories that 
		/// should be ignored when processing</param>
		/// <param name="isDebugMode">Flag that web application is in debug mode</param>
		/// <param name="coreConfig">Configuration settings of core</param>
		protected TransformerBase(string[] ignorePatterns, bool isDebugMode, CoreSettings coreConfig)
		{
			_ignorePatterns = ignorePatterns;
			_isDebugMode = isDebugMode;
			_coreConfig = coreConfig;
		}


		/// <summary>
		/// Starts a processing of assets
		/// </summary>
		/// <param name="context">Object BundleContext</param>
		/// <param name="response">Object BundleResponse</param>
		public void Process(BundleContext context, BundleResponse response)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context", Strings.Common_ValueIsNull);
			}

			if (response == null)
			{
				throw new ArgumentNullException("response", Strings.Common_ValueIsNull);
			}

			if (!context.EnableInstrumentation)
			{
				var assets = new List<IAsset>();
				IEnumerable<FileInfo> assetFiles = response.Files;

				foreach (var assetFile in assetFiles)
				{
					assets.Add(new Asset(assetFile.FullName));
				}

				Transform(assets, response, context.HttpContext);
			}
		}

		/// <summary>
		/// Transforms assets
		/// </summary>
		/// <param name="assets">Set of assets</param>
		/// <param name="bundleResponse">Object BundleResponse</param>
		/// <param name="httpContext">Object HttpContext</param>
		protected abstract void Transform(IList<IAsset> assets, BundleResponse bundleResponse, HttpContextBase httpContext);

		/// <summary>
		/// Validates assets for compliance with a valid types
		/// </summary>
		/// <param name="assets">Set of assets</param>
		protected abstract void ValidateAssetTypes(IList<IAsset> assets);

		/// <summary>
		/// Removes duplicate assets
		/// </summary>
		/// <param name="assets">Set of assets</param>
		/// <returns>Set of unique assets</returns>
		protected abstract IList<IAsset> RemoveDuplicateAssets(IList<IAsset> assets);

		/// <summary>
		/// Removes unnecessary assets
		/// </summary>
		/// <param name="assets">Set of assets</param>
		/// <returns>Set of necessary assets</returns>
		protected abstract IList<IAsset> RemoveUnnecessaryAssets(IList<IAsset> assets);

		protected virtual IList<IAsset> Translate(IList<IAsset> assets)
		{
			IList<IAsset> processedAssets = assets;

			foreach (var translator in _translators)
			{
				translator.IsDebugMode = _isDebugMode;

				processedAssets = translator.Translate(processedAssets);
			}

			return processedAssets;
		}

		/// <summary>
		/// Replaces file extensions of assets
		/// </summary>
		/// <param name="assets">Set of assets</param>
		/// <returns>Set of assets with a modified extension</returns>
		protected abstract IList<IAsset> ReplaceFileExtensions(IList<IAsset> assets);

		/// <summary>
		/// Minify text content of assets
		/// </summary>
		/// <param name="assets">Set of assets</param>
		/// <returns>Set of assets with minified text content</returns>
		protected virtual IList<IAsset> Minify(IList<IAsset> assets)
		{
			IList<IAsset> processedAssets = _minifier.Minify(assets);

			return processedAssets;
		}

		/// <summary>
		/// Combines code of assets
		/// </summary>
		/// <param name="assets">Set of assets</param>
		/// <param name="enableTracing">Enables tracing</param>
		protected abstract string Combine(IList<IAsset> assets,
			bool enableTracing);

		/// <summary>
		/// Configures bundle response
		/// </summary>
		/// <param name="assets">Set of assets</param>
		/// <param name="bundleResponse">Object BundleResponse</param>
		/// <param name="httpContext">Object HttpContext</param>
		protected virtual void ConfigureBundleResponse(IList<IAsset> assets, BundleResponse bundleResponse, HttpContextBase httpContext)
		{
			var assetFiles = new List<FileInfo>();

			foreach (var asset in assets)
			{
				assetFiles.Add(new FileInfo(asset.Path));
			}

			bundleResponse.Files = assetFiles;
		}

		/// <summary>
		/// Destroys object
		/// </summary>
		public abstract void Dispose();
	}
}
