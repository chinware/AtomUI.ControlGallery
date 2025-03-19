param (
    [string]$publishRootPath = "D:/publish",
    [string]$buildType = "Release",
    [string]$framework = "net9.0",
    [string]$runtime = "osx-arm64",
    [string]$buildTimestamp
)

if ([string]::IsNullOrEmpty($buildTimestamp)) {
    $buildTimestamp = Get-Date -Format 'yyyyMMddHHmm'
}

if (Test-Path -Path $publishRootPath -PathType Container) {
    Remove-Item -Path $publishRootPath -Recurse -Force
}

$configPath = Join-Path -Path $publishRootPath -ChildPath "config"
$packagesPath = Join-Path -Path $publishRootPath -ChildPath "packages"

New-Item -Path $publishRootPath -ItemType Directory -Force | Out-Null
New-Item -Path $configPath -ItemType Directory -Force | Out-Null
New-Item -Path $packagesPath -ItemType Directory -Force | Out-Null

dotnet publish --output $packagesPath --self-contained --framework $framework --runtime $runtime --configuration $buildType -p:PublishSingleFile=true ../AtomUIGallery.Desktop.csproj
if ($IsMacOS) {
    Copy-Item -Path ../configs/InstallerConfig.dmg.xml -Destination $configPath/InstallerConfig.xml -Force
}
