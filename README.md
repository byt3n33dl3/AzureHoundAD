<h1 align="center">AzureHoundAD</h1>

<h1 align="center">
  <img src="/img/master.png" alt="AzureHoundAD" width="280px">
  <br>
</h1>

<p align="center">
  <a href="#features">Features</a> •
  <a href="#installation">Installation</a> •
  <a href="#usage">Usage</a> •
  <a href="#scope-control">Scope</a>
</p>

<p align="center">
The Attack Path Management data collector for Microsoft Azure

AzureHoundAD collects data from Azure Active Directory (AzureAD) and Azure Resource Manager (AzureRM). It can then send this data to Attack Path Management, maybe BloodHound Enterprise for processing and analysis.
</p>

AzureHoundAD uses the `Microsoft` Graph and Azure REST APIs to collect data. It can run on any operating system and doesn't require any external dependencies. Authentication Attack with AzureHoundAD supports several `Authentication` flows, including username or password, JWT, refresh token, service principal secret, and service principal certificate.

- AzureHound is a Go binary that collects data from AzureAD and AzureRM via the MS Graph and Azure REST APIs. 

## Get AzureHoundAD

<p align="center">
  <a href="#crawler-configuration">Config</a> •
  <a href="#filters">Filters</a> •
  <a href="https://discord.gg/projectdiscovery">AzureAD</a>
</p>

Download the appropriate binary for your platform from one of our [Releases](https://github.com/byt3n33dl3/AzureHoundAD/releases).

The rolling release contains pre-built binaries that are automatically kept up-to-date with the `main` branch and can be downloaded from
[here](https://github.com/byt3n33dl3/AzureHoundAD/releases/tag/rolling).

> **Warning:** The rolling release may be unstable.

## Compiling

- Go [1.21](https://go.dev/dl) or later

To build this project from source run the following:

```sh
go build -ldflags="-s -w -X github.com/byt3n33dl3/AzureHoundAD/v2/constants.Version=`git describe tags --exact-match 2> /dev/null || git rev-parse HEAD`"
```

## Usage

**Print all Azure Tenant data to stdout**

```sh
❯ azurehound list -u "$USERNAME" -p "$PASSWORD" -t "$TENANT"
```

**Print all Azure Tenant data to file**

```sh
❯ azurehound list -u "$USERNAME" -p "$PASSWORD" -t "$TENANT" -o "mytenant.json"
```

**Configure and start data collection service for BloodHound Enterprise**

```sh
❯ azurehound configure
(follow prompts)

❯ azurehound start
```

## Command Line

```
❯ azurehound --help
AzureHound vx.x.x
Created by the BloodHound Enterprise team -

The official tool for collecting Azure data for BloodHound and BloodHound Enterprise

Usage:
  azurehound [command]

Available Commands:
  completion  Generate the autocompletion script for the specified shell
  configure   Configure AzureHound
  help        Help about any command
  list        Lists Azure Objects
  start       Start Azure data collection service for BloodHound Enterprise

Flags:
  -c, --config string          AzureHound configuration file (.config/azurehound/config.json)
  -h, --help                   help for azurehound
      --json                   Output logs as json
  -j, --jwt string             Use an acquired JWT to authenticate into Azure
      --log-file string        Output logs to this file
      --proxy string           Sets the proxy URL for the AzureHound service
  -r, --refresh-token string   Use an acquired refresh token to authenticate into Azure
  -v, --verbosity int          AzureHound verbosity level (defaults to 0) [Min: -1, Max: 2]
      --version                version for azurehound

Use "azurehound [command] --help" for more information about a command.
```
## Thanks To

<p align="left">
<a href="https://github.com/byt3n33dl3"><img src="https://avatars.githubusercontent.com/u/151133481?v=4" width="50" height="50" alt="" style="max-width: 100%;"></a>
<a href="https://github.com/BloodHoundAD"><img src="https://avatars.githubusercontent.com/u/25502277?s=200&v=4" width="50" height="50" alt="" style="max-width: 100%;"></a>
<a href="https://github.com/specterops"><img src="https://avatars.githubusercontent.com/u/25406560?s=200&v=4" width="50" height="50" alt="" style="max-width: 100%;"></a>
<a href="https://github.com/chrismaddalena"><img src="https://avatars.githubusercontent.com/u/10526228?v=4" width="50" height="50" alt="" style="max-width: 100%;"></a>
</p>