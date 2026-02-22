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
using System.Runtime.CompilerServices;
#if ASF_SIGNED_BUILD
using SharkFarm;
#endif

[assembly: CLSCompliant(false)]

#if ASF_SIGNED_BUILD
[assembly: InternalsVisibleTo($"SharkFarm.Tests, PublicKey={SharedInfo.PublicKey}")]
[assembly: InternalsVisibleTo($"SharkFarm.CustomPlugins.SignInWithSteam, PublicKey={SharedInfo.PublicKey}")]
[assembly: InternalsVisibleTo($"SharkFarm.OfficialPlugins.ItemsMatcher, PublicKey={SharedInfo.PublicKey}")]
[assembly: InternalsVisibleTo($"SharkFarm.OfficialPlugins.MobileAuthenticator, PublicKey={SharedInfo.PublicKey}")]
[assembly: InternalsVisibleTo($"SharkFarm.OfficialPlugins.Monitoring, PublicKey={SharedInfo.PublicKey}")]
[assembly: InternalsVisibleTo($"SharkFarm.OfficialPlugins.SteamTokenDumper, PublicKey={SharedInfo.PublicKey}")]
#else
[assembly: InternalsVisibleTo("SharkFarm.Tests")]
[assembly: InternalsVisibleTo("SharkFarm.CustomPlugins.SignInWithSteam")]
[assembly: InternalsVisibleTo("SharkFarm.OfficialPlugins.ItemsMatcher")]
[assembly: InternalsVisibleTo("SharkFarm.OfficialPlugins.MobileAuthenticator")]
[assembly: InternalsVisibleTo("SharkFarm.OfficialPlugins.Monitoring")]
[assembly: InternalsVisibleTo("SharkFarm.OfficialPlugins.SteamTokenDumper")]
#endif
