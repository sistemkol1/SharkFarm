// ----------------------------------------------------------------------------------------------
//     _                _      _  ____   _                           _____
//    / \    _ __  ___ | |__  (_)/ ___| | |_  ___   __ _  _ __ ___  |  ___|__ _  _ __  _ __ ___
//   / _ \  | '__|/ __|| '_ \ | |\___ \ | __|/ _ \ / _` || '_ ` _ \ | |_  / _` || '__|| '_ ` _ \
//  / ___ \ | |  | (__ | | | || | ___) || |_|  __/| (_| || | | | | ||  _|| (_| || |   | | | | | |
// /_/   \_\|_|   \___||_| |_||_||____/  \__|\___| \__,_||_| |_| |_||_|   \__,_||_|   |_| |_| |_|
// ----------------------------------------------------------------------------------------------
// |
// Copyright 2015-2026 Łukasz "SharkFarmDev" Domeradzki
// Contact: SharkFarmDev@SharkFarmDev.net
// |
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// |
// http://www.apache.org/licenses/LICENSE-2.0
// |
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Threading.Tasks;
using SharkFarm.Core;
using SharkFarm.Localization;
using SharkFarm.NLog;
using SharkFarm.Storage;
using SharkFarm.Web;
using SharkFarm.Web.GitHub;
using SharkFarm.Web.GitHub.Data;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharkFarm.Tests;

#pragma warning disable CA1812 // False positive, the class is used during MSTest
[TestClass]
internal sealed class IGitHubPluginUpdates : TestContextBase {
	private const string PluginName = "SharkFarm.OfficialPlugins.Monitoring";
	private const string Repository = "SharkFarmNET/SharkFarm";

	[UsedImplicitly]
	public IGitHubPluginUpdates(TestContext testContext) : base(testContext) => ArgumentNullException.ThrowIfNull(testContext);

	[TestCategory("Manual")]
	[TestMethod]
	internal async Task DoesNotOfferPointlessUpdatesWhenMultipleAssetsAreFound() {
		using WebBrowser webBrowser = new(new ArchiLogger("Test"));

		typeof(ASF).GetProperty(nameof(ASF.WebBrowser))?.SetValue(null, webBrowser);

		ReleaseResponse? response = await GitHubService.GetLatestRelease(Repository, cancellationToken: CancellationToken).ConfigureAwait(false);

		if (response == null) {
			Assert.Inconclusive(Strings.FormatWarningFailedWithError(nameof(response)));
		}

		Version version = Version.Parse(response.Tag);

		Plugins.Interfaces.IGitHubPluginUpdates plugin = new TestGitHubPluginUpdates(version);

		Uri? releaseURL = await plugin.GetTargetReleaseURL(version, BuildInfo.Variant, true, GlobalConfig.EUpdateChannel.Stable, false).ConfigureAwait(false);

		Assert.IsNull(releaseURL);

		Uri? forcedReleaseURL = await plugin.GetTargetReleaseURL(version, BuildInfo.Variant, true, GlobalConfig.EUpdateChannel.Stable, true).ConfigureAwait(false);

		Assert.IsNotNull(forcedReleaseURL);
	}

	private sealed class TestGitHubPluginUpdates : Plugins.Interfaces.IGitHubPluginUpdates {
		public string Name => PluginName;
		public string RepositoryName => Repository;
		public Version Version { get; }

		internal TestGitHubPluginUpdates(Version version) {
			ArgumentNullException.ThrowIfNull(version);

			Version = version;
		}

		public Task OnLoaded() => Task.CompletedTask;
	}
}
#pragma warning restore CA1812 // False positive, the class is used during MSTest
