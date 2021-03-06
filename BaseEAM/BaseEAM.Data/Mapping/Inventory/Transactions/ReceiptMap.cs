﻿/*******************************************************
 * Copyright 2016 (C) BaseEAM Systems, Inc
 * All Rights Reserved
*******************************************************/
using BaseEAM.Core.Domain;

namespace BaseEAM.Data.Mapping
{
    public class ReceiptMap : BaseEamWorkflowEntityTypeConfiguration<Receipt>
    {
        public ReceiptMap()
        {
            this.ToTable("Receipt");
            //this.Property(s => s.Number).HasMaxLength(64);
            //this.Property(s => s.Description).HasMaxLength(512);
            this.HasOptional(e => e.Site)
                .WithMany()
                .HasForeignKey(e => e.SiteId);
            this.HasOptional(e => e.Store)
                .WithMany()
                .HasForeignKey(e => e.StoreId);
            this.HasOptional(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId);
        }
    }
}
