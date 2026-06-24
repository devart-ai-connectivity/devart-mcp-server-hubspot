// --------------------------------------------------------------------------
// <copyright file="OdbcHubSpotAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.Odbc.HubSpot
{
  internal sealed class OdbcHubSpotAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "HubSpot";

    public override bool OnPremise => false;
  }
}
