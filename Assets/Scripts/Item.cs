using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public List<BaseStat> Stats { get; set; }
    public string ObjectSlug { get; set; }
    public string Description { get; set; }
    public string ActionName { get; set; }
    public string ItemName { get; set; }
    public bool ItemModified { get; set; }

    public Item(List<BaseStat> _Stats, string _ObjectSlug) {
        this.Stats = _Stats;
        this.ObjectSlug = _ObjectSlug;
    }

    public Item(List<BaseStat> _Stats, string _ObjectSlug, string _Description, string _ActionName, string _ItemName, bool _ItemModified) {
        this.Stats = _Stats;
        this.ObjectSlug = _ObjectSlug;
        this.Description = _Description;
        this.ActionName = _ActionName;
        this.ItemModified = _ItemModified;
        this.ItemName = _ItemName;
    }
}
