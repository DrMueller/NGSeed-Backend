﻿using Mmu.Mlh.DataAccess.Areas.DatabaseAccess.Models;
using Mmu.Ngs.WebApi.Infrastructure.Settings.Models.SubSettings;

namespace Mmu.Ngs.WebApi.Infrastructure.Settings.Models
{
    public class AppSettings
    {
        public const string SectionName = "AppSettings";
        public bool ActivateSecurity { get; set; }
        public AzureAdSettings AzureAdSettings { get; set; }
        public DatabaseSettings DatabaseSettings { get; set; }
    }
}