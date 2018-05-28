# BTMLAddBindableEscapeKey
BattleTech Mod (using [BTML](https://github.com/Mpstark/BattleTechModLoader) and [ModTek](https://github.com/Mpstark/ModTek)) that adds a keybind (default `space`) to the game that does the same thing as `Escape`.

## Download
Downloads can be found on [Github](https://github.com/gponick/BTMLAddBindableEscapeKey/releases) 

## Install
- [Install BTML and Modtek](https://github.com/Mpstark/ModTek/wiki/The-Drop-Dead-Simple-Guide-to-Installing-BTML-&-ModTek-&-ModTek-mods).
- Put the `BTMLAddBindableEscapeKey.dll` and `mod.json` files into `\BATTLETECH\Mods\BTMLAddBindableEscapeKey` folder.
- If you want to change the settings do so in the mod.json.
- Start the game.

## Default Bindings

`space`

`Mouse4`

## Settings


Setting | Type | Default | Description
--- | --- | --- | ---
escapeMouseButton | int | 4 | Which Mouse Button to Bind to. Default: `4`. Valid Values: `[4-9]`
enableSpaceKey | bool | true | Enable Space Key
enableMouseButton | bool | true | Enable Mouse Buttone

## Special Thanks

HBS, @LadyAlekto, @Mpstark, @Morphyum, @janxious, @CWolf


## Maintainer Notes: New HBS Patch Instructions

* pop open VS
* grab the latest version of the assembly
* copy the new version of the methods in `original_src` over the existing ones
* see if anything important changed via git
