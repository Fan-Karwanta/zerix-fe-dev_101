# Zerix FE — Project Notes

## Typography (project-wide standard)

**All pages use `Plus Jakarta Sans`.** Do not introduce `Microsoft Sans Serif` or any
other family for new UI.

- Declared once in `wwwroot/css/site.css`: an `@import` for the Google Font plus a
  `* { font-family: 'Plus Jakarta Sans', sans-serif; }` base rule. Every main-app
  layout loads `site.css`, so new pages inherit the font automatically.
- `site.css` also re-asserts `font-family: "bootstrap-icons"` for `[class^="bi-"]` /
  `[class*=" bi-"]` so the universal rule does not break icon glyphs. Keep this carve-out
  when touching font rules.
- Per-element `font-size` / `font-weight` / `line-height` still come from each
  component's own CSS and should match its Figma frame. Only the *family* is global.
- Exception: `wwwroot/SuperAdmin/css/*` is a separate design system using bundled
  Satoshi / Inter / Poppins fonts (`wwwroot/SuperAdmin/fonts/`). It was intentionally
  left on Satoshi. Confirm with the user before changing SuperAdmin typography.

## Build / verify

The app is usually running from Visual Studio, which locks `bin\Debug\net8.0\zerix-fe-dev.exe`
and makes `dotnet build` fail with MSB3021/MSB3026 copy errors. Those are **not** code errors.

To verify Razor/C# compiles without stopping the running app:

```
dotnet msbuild -t:Compile -v:q -nologo
```

Exit code 0 = clean. Razor pages are compiled by a source generator as part of `Compile`.

## Razor gotcha

In `.cshtml` files, CSS at-rules inside `<style>` blocks must be escaped as `@@media`,
`@@keyframes`, etc. A bare `@media` is parsed as a Razor expression and breaks the build.
