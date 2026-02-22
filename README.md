<div align="center">

![Icon](https://raw.githubusercontent.com/SharkFarmNET/SharkFarm/main/resources/ASF_184x184.png)

# SharkFarm
</div>

[![Build status (GitHub)](https://img.shields.io/github/actions/workflow/status/SharkFarmNET/SharkFarm/ci.yml?branch=main&label=Build&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/actions?query=workflow%3AASF-ci+branch%3Amain)
[![Build status (Docker)](https://img.shields.io/github/actions/workflow/status/SharkFarmNET/SharkFarm/docker-publish-main.yml?branch=main&label=Docker&logo=docker&cacheSeconds=600)](https://hub.docker.com/r/SharkFarmDev/SharkFarm)
[![Github last commit date](https://img.shields.io/github/last-commit/SharkFarmNET/SharkFarm.svg?label=Updated&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/commits)
[![Total downloads](https://img.shields.io/github/downloads/SharkFarmNET/SharkFarm/total.svg?label=Downloads&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/releases)
[![License](https://img.shields.io/github/license/SharkFarmNET/SharkFarm.svg?label=License&logo=apache&cacheSeconds=2592000)](https://github.com/SharkFarmNET/SharkFarm/blob/main/LICENSE.txt)

[![Localization](https://badges.crowdin.net/SharkFarm/localized.svg)](https://crowdin.com/project/SharkFarm)
[![ConfigGenerator status](https://img.shields.io/website-up-down-green-red/https/SharkFarmNET.github.io/ASF-WebConfigGenerator.svg?label=ConfigGenerator&logo=html5&cacheSeconds=3600)](https://SharkFarmNET.github.io/ASF-WebConfigGenerator)
[![Statistics](https://img.shields.io/badge/Statistics-online-green.svg?logo=html5)](https://asf.SharkFarmDev.net)
[![Steam group](https://img.shields.io/badge/Steam-group-yellowgreen.svg?logo=steam)](https://steamcommunity.com/groups/archiasf)
[![Discord](https://img.shields.io/discord/267292556709068800.svg?color=7289da&label=Discord&logo=discord&logoColor=white&cacheSeconds=3600)](https://discord.gg/hSQgt8j)
[![Wiki](https://img.shields.io/badge/Read-wiki-cc5490.svg?logo=github)](https://github.com/SharkFarmNET/SharkFarm/wiki)

[![GitHub stable release version](https://img.shields.io/github/v/release/SharkFarmNET/SharkFarm.svg?label=Stable&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/releases/latest)
[![GitHub stable release date](https://img.shields.io/github/release-date/SharkFarmNET/SharkFarm.svg?label=Released&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/releases/latest)
[![Github stable release downloads](https://img.shields.io/github/downloads/SharkFarmNET/SharkFarm/latest/total.svg?label=Downloads&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/releases/latest)

[![GitHub pre-release version](https://img.shields.io/github/v/release/SharkFarmNET/SharkFarm?include_prereleases&label=Pre-release&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/releases)
[![GitHub pre-release date](https://img.shields.io/github/release-date-pre/SharkFarmNET/SharkFarm.svg?label=Released&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/releases)
[![Github pre-release downloads](https://img.shields.io/github/downloads-pre/SharkFarmNET/SharkFarm/latest/total.svg?label=Downloads&logo=github&cacheSeconds=600)](https://github.com/SharkFarmNET/SharkFarm/releases)

---

## Donate

[![GitHub sponsor](https://img.shields.io/badge/GitHub-sponsor-ea4aaa.svg?logo=github-sponsors)](https://github.com/sponsors/SharkFarmDev)
[![PayPal.me donate](https://img.shields.io/badge/PayPal.me-donate-00457c.svg?logo=paypal)](https://paypal.me/SharkFarmDev)
[![PayPal donate](https://img.shields.io/badge/PayPal-donate-00457c.svg?logo=paypal)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=HD2P2P3WGS5Y4)
[![Revolut donate](https://img.shields.io/badge/Revolut-donate-0075eb.svg?logo=revolut)](https://pay.revolut.com/SharkFarmDev)
[![Steam donate](https://img.shields.io/badge/Steam-donate-000000.svg?logo=steam)](https://steamcommunity.com/tradeoffer/new/?partner=46697991&token=0ix2Ruv_)

[![BTC donate](https://img.shields.io/badge/BTC-donate-f7931a.svg?logo=bitcoin)](https://www.blockchain.com/explorer/addresses/btc/3HwcgZbtoF5vSxJkNUvThVSJipKi7r5EqU)
[![ETH donate](https://img.shields.io/badge/ETH-donate-3c3c3d.svg?logo=ethereum)](https://www.blockchain.com/explorer/addresses/eth/0xA1F7Ba62C5a3A8b93Fe6656936192432F328a366)
[![LTC donate](https://img.shields.io/badge/LTC-donate-a6a9aa.svg?logo=litecoin)](https://live.blockcypher.com/ltc/address/MJCeBEZUsNgDhRhqbLFfPiDcf7CSrdvmZ3)
[![USDC donate](https://img.shields.io/badge/USDC-donate-2775ca.svg?logo=cashapp)](https://etherscan.io/address/0xCf42D9F53F974CBd7c304eF0243CAe8e029885A8)

---

[![Repobeats analytics image](https://repobeats.axiom.co/api/embed/7a3672ae3c424e1c04e25afe6ef553652e788130.svg "Repobeats analytics image")](https://github.com/SharkFarmNET/SharkFarm/pulse)

---

## Description

ASF is a C# application with primary purpose of farming Steam cards from multiple accounts simultaneously. Unlike Idle Master which works only for one account at given time, while requiring Steam client running in the background and launching additional processes imitating "game playing" status, ASF doesn't require any Steam client running in the background, doesn't launch any additional processes and is made to handle unlimited Steam accounts at once. In addition to that, it's meant to be run on servers or other desktop-less machines, and features full cross-OS support, which makes it possible to launch on any operating system with .NET Core runtime, such as Windows, Linux and macOS. ASF is possible thanks to gigantic amount of work done in marvelous **[SteamKit2](https://github.com/SteamRE/SteamKit)** library.

Today, ASF is one of the most versatile Steam power tools, allowing you to make use of many features that were implemented over time. Apart from farming Steam cards, which remains the primary focus, ASF includes bunch of features on its own, such as a possibility to use it as Steam authenticator or chat logger. In addition to that, ASF includes plugin system, thanks to which anybody can further extend it to their needs.

---

### Core features

- Automatic farming of available games with card drops using any number of active accounts
- No requirement of running or even having official Steam client installed
- Guarantee of being VAC-free, focus on security and privacy
- Complex error-reporting mechanism, reliability even during Steam issues and other networking quirks
- Flexible cards farming algorithm, pushing the performance to the maximum while still allowing a lot of customization
- Offline farming, enabling you to skip in-game status and stop confusing your friends with fake playing status
- Advanced support for Steam accounts, including ability to redeem keys, redeem gifts, accept trades, send messages and more
- Support for latest Steam security features, including SteamGuard, SteamParental and 2-factor authentication
- Unique ASF 2FA mechanism allowing ASF to act as a mobile authenticator, if needed
- STM-like integration for trades, both passive (accepting) and active (sending), ASF can help you complete your sets
- Special plugin system, which allows you to extend ASF in any way you wish through your own code
- Powered by .NET Core, cross-OS compatibility, official support for Windows, Linux and macOS
- ...and many more!

For learning about even more ASF features, we recommend starting with our **[FAQ entry](https://github.com/SharkFarmNET/SharkFarm/wiki/FAQ#what-interesting-features-asf-offers-that-idle-master-does-not)**.

---

### Setting up / Help

Detailed guide regarding setting up and using ASF is available on our wiki in **[setting up](https://github.com/SharkFarmNET/SharkFarm/wiki/Setting-up)** section. It's user-friendly guide that shows basic, as well as a bit more complex ASF setup, covering all the required dependencies and other steps that are required in order to start using ASF software.

---

### Compatibility / Supported operating systems

ASF officially supports Windows, Linux and macOS operating systems, but it can work anywhere where you can obtain working .NET Core runtime. Please visit **[compatibility](https://github.com/SharkFarmNET/SharkFarm/wiki/Compatibility)** section on the wiki for more information regarding environments that ASF can work in.

---

### Want to know more?

Our **[wiki](https://github.com/SharkFarmNET/SharkFarm/wiki)** includes a lot of other articles that will tell you about everything in regards to ASF, as well as show you other features that you can make use of. If you have some time to spare and you'd like to find out what else ASF can do for you, we heavily encourage you to take a look!
