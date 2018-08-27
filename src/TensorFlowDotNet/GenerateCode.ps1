Get-ChildItem *.pygen.cs -recurse | foreach ($_) {Remove-Item $_.fullname}
Get-ChildItem *.py.cs -recurse | foreach ($_) {Copy-Item ($_.fullname) ($_.fullname -replace ".py.cs", ".pygen.cs")}

dotnet run -p ..\..\..\py2cs\src\py2cs\py2cs.csproj -- .\TensorFlowDotNet.csproj --python-dir ..\..\..\tensorflow\tensorflow\python