#region Copyright (C) 2003-2012 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports.Net											}
{																	}
{	Copyright (C) 2003-2012 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2012 Stimulsoft

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;

[assembly: AssemblyTitle("Demo.exe")]
[assembly: AssemblyDescription("Stimulsoft Reports.Net Demo")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Stimulsoft")]
[assembly: AssemblyProduct("Stimulsoft Reports.Net")]
[assembly: AssemblyCopyright("Copyright (C) 2003-2012 Stimulsoft")]
[assembly: AssemblyTrademark("Stimulsoft")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion(StiVersion.Version)]
[assembly: AssemblyDelaySign(false)]

#if Net4
[assembly: SecurityRules(SecurityRuleSet.Level1)]
#endif