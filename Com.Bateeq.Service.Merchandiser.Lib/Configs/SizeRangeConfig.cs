﻿using Com.Bateeq.Service.Merchandiser.Lib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Bateeq.Service.Merchandiser.Lib.Configs
{
    public class SizeRangeConfig : IEntityTypeConfiguration<SizeRange>
    {
        public void Configure(EntityTypeBuilder<SizeRange> builder)
        {
            builder.Property(c => c.Code).HasMaxLength(100);
            builder.Property(c => c.Name).HasMaxLength(500);
        }
    }
}
