$root = 'C:\Users\Admin\Desktop\fan_folder\projects_folder\zerix_folder\zerix-fe-dev_101\Pages'
$files = Get-ChildItem -Path $root -Recurse -Include *.cshtml,*.html

$replacements = [ordered]@{
    'btn-orange-fill'    = 'btn-brand'
    'btn-outline-orange' = 'btn-outline-brand'
    'bg-color-ff5400'    = 'bg-color-brand'
    'bg-orange-light'    = 'bg-brand-light'
    'font-orange'        = 'text-brand'
    'border-orange'      = 'border-default'
    'btn-orange'         = 'btn-nav'
    'text-orange'        = 'text-brand'
    'orange-circle'      = 'brand-circle'
}

$changedFiles = @()

foreach ($file in $files) {
    $content = Get-Content -Path $file.FullName -Raw -Encoding UTF8
    $original = $content
    foreach ($key in $replacements.Keys) {
        $pattern = '\b' + [regex]::Escape($key) + '\b'
        $content = [regex]::Replace($content, $pattern, $replacements[$key])
    }
    if ($content -ne $original) {
        [System.IO.File]::WriteAllText($file.FullName, $content, (New-Object System.Text.UTF8Encoding($false)))
        $changedFiles += $file.FullName
    }
}

Write-Output "Changed files count: $($changedFiles.Count)"
$changedFiles | ForEach-Object { Write-Output $_ }
