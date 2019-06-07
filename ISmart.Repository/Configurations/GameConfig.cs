using iSmart.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISmart.Repository.Configurations
{
    public class GameConfig
    {
        public GameConfig(EntityTypeBuilder<Game> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
        }
    }
}
