// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Most other implementations of this call use load from an async source.  This might change to that later, causing a method signature change if we decided to change it later.", Scope = "member", Target = "~M:M3H5Lib.M3Config.GetConfig(System.String,System.Int32,System.String,System.String,System.String,System.Boolean,System.Int32,System.Threading.CancellationToken)~System.Threading.Tasks.Task{M3H5Lib.M3Config}")]
