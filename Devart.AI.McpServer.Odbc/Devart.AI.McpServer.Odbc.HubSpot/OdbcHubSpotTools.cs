// --------------------------------------------------------------------------
// <copyright file="OdbcHubSpotTools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using ModelContextProtocol.Server;
using Devart.AI.McpServer.Odbc.HubSpot.Tools;

namespace Devart.AI.McpServer.Odbc.HubSpot
{
  internal static class OdbcHubSpotTools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcHubSpotPrimaryKeysTool(configuration))
        .Add(new OdbcHubSpotForeignKeysTool(configuration))
        .Build();
  }
}
