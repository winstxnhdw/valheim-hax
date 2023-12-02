# valheim-hax

![main.yml](https://github.com/winstxnhdw/valheim-hax/actions/workflows/main.yml/badge.svg)

Internal cheats for [Valheim](https://en.wikipedia.org/wiki/Valheim).

## Requirements

- Windows 10 or higher
- [Microsoft .NET SDK](https://dotnet.microsoft.com/en-us/download)

## Installation

```bash
git clone --recursive https://github.com/winstxnhdw/valheim-hax.git
```

You can now build and install the dependencies by executing `requirements.bat`. It is not required to build dnSpy if you do not plan on doing any [development](#development).

## Usage

Execute `launch.bat` when you have lauched the game.

## Development

[dnSpy](https://github.com/dnSpy/dnSpy) is included as a submodule when you recursively clone this directory. If you plan to contribute to the development, dnSpy is an invaluable tool for browsing the Raft source code. You may compile dnSpy by executing `requirements.bat` and entering `Y` when the prompt to build dnSpy appears. You can then run the compiled dnSpy executable.

```bash
dnSpy/dnSpy.exe &
```
