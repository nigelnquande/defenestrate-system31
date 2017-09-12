# Defenestrate (System 31)

> Defenestrate: verb (used with object), defenestrated, defenestrating.
> 1. to throw (a person or thing) out of a window.

Source: [Dictionary.com](http://www.dictionary.com/browse/defenestrate)

"Defenestrate (System 31)" is a collection of fake `System32` tools to frustrate "software support" scammers, written in C#

These tools should work cross-platform on Mono.

# Tools/Utilities Provided

The following tools have been completed:

+ Fake Syskey: Looks/behaves like real Syskey, but doesn't change the System Account Management (SAM) database. It **will** purposefully pop up an error message if you select "Save to Floppy Disk" and click <kbd>OK</kbd> on the resulting dialog (regardless of whether there actually is an `A:\` drive and a disk in it).

The below tools are still in development, but the end result of this project is to produce the following:

+ Fake Eventviewr
+ Fake Notepad
+ Fake Control Panel
+ Fake Run Dialog (possibly)
+ Fake `tree`: will recursively output a list the contents of the `C:` drive (or first available drive if not `C:`) for five minutes.
+ Fake `netstat`
+ Fake `ipconfig`
+ Fake `msinfo32`

+ Fake `hosts`: Text file containing a list of website domains frequently used by scammers, mapped to `localhost` (`127.0.0.1`), as well as directories of clean mimic versions of those sites (preferabbly in plain HTML and JS/Node).
  + includes Hurr-Durr

# Usage

For most effective use, on a VM behind a VPN:

1. Create a `C:\` drive (or, on \*NIX, change your shell prompt to look like Windows command prompt's, *id est*, prepend `C:` to path, replace `/` with `\` and place `>` after it. Then, alias `cmd` to whatever shell you use.)
2. Install Windows on another drive (Eg: `D:\`)
3. Create the directory path `C:\Windows\System32` (or `/Windows/System32` on \*NIX) and place the fake tools there.
4. Prepend `C:\Windows\System32` (or `/Windows/System32` on \*NIX) to your `PATH` variable.
5. On \*NIX, create a directory link named `/Users/` that maps to `/home/` (optional)
6. ON \*NIX, add the following to the global `bash_profile` file located in `/etc/`:  `export WINDIR="/Windows"`
6. Confuse/frustrate scammers.

_Note:_ This project makes use of the [UIToolbox.RadioGroupBox](https://www.codeproject.com/Articles/32780/CheckGroupBox-and-RadioGroupBox) library Copyright &copy; 2009 by Jeff Beeghly. It is also available on [GitHub](https://github.com/DigitalGlobe/DGConnect-ESRI/tree/master/GbdxTools).