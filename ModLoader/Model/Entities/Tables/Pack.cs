﻿
using ModLoader.Model.Entities.Base;
using System;
using System.Linq;

namespace ModLoader.Model.Entities.Tables
{
    public class Pack : TableFields
    {
        public virtual ModCollection ModCollection { get; set; }
        public int ModCollectionId { get; set; }
        public DateTime DateUpdate { get; set; }


        public static void Create(string name, int parentId)
        {
            new EFGenericRepository<Pack>().CreateOrSkip(new Pack { Name = name, ModCollectionId = parentId });
        }

        public static Pack Find(string name)
        {
            return new Context().Set<Pack>().Where(Pack => Pack.Name == name).FirstOrDefault();
        }
    }
}