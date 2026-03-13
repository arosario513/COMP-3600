# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

```sh
make build   # dotnet publish -r win-x64
make run     # run the built exe via Wine
make format  # dotnet format
make clean   # dotnet clean + remove bin/obj
```

The project targets `net10.0-windows` and produces a Windows executable. Building and running on Linux requires Wine (run via `wine ./bin/Release/net10.0-windows/win-x64/ghosts.exe`).

## Architecture

This is a C# Windows Forms (WinForms) application for COMP-3600 Computer Graphics coursework.

- **`Program.cs`** — entry point; initializes the WinForms application and launches `Form1`.
- **`Form1.cs`** — main form with custom GDI+ drawing logic. Graphics are rendered by overriding `OnPaint`. Helper methods (`DrawGhost`, `DrawEye`) use `System.Drawing` primitives (`Graphics`, `Brush`, `Pen`, ellipses).
- **`Form1.Designer.cs`** — auto-generated designer file for `Form1`; do not manually edit.

All rendering uses `System.Drawing` (GDI+) via the `Graphics` object passed in `PaintEventArgs`. New drawing logic should go in `Form1.cs` using the same pattern: add helper `Draw*` methods and call them from `OnPaint`.
