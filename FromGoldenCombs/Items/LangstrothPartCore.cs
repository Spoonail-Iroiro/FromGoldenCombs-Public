using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Util;

namespace FromGoldenCombs.Items
{
    class LangstrothPartCore : Item
    {

        /// <summary>Called by the inventory system when you hover over an item stack. This is the item stack name that is getting displayed.</summary>
        /// <param name="itemStack"></param>
        /// <returns>
        ///   Computed string showing the materials the item is made from.
        /// </returns>
        public override string GetHeldItemName(ItemStack itemStack)
        {
            string materialPrimary = Lang.Get($"material-{VariantStrict["primary"]}").UcFirst();
            string? materialAccent = itemStack.Collectible.Variant["accent"] != null ? Lang.Get($"material-{Variant["accent"]}").UcFirst() : null;
            string materials = materialAccent != null ? Lang.Get("fromgoldencombs:materials", materialPrimary, materialAccent) : materialPrimary;
            return Lang.Get("fromgoldencombs:item-langstrothpart", base.GetHeldItemName(itemStack), materials);
        }
    }
}
