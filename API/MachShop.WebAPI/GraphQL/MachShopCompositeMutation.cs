﻿using GraphQL.Types;
using System.Collections.Generic;
using MachShop.WebAPI.GraphQL.Configuration;

namespace MachShop.WebAPI.GraphQL
{
    public sealed class MachShopCompositeMutation : ObjectGraphType<object>
    {
        public MachShopCompositeMutation(IEnumerable<IGraphMutationMarker> graphMutationMarkers)
        {
            Name = "MachShopCompositeMutation";
            foreach (var marker in graphMutationMarkers)
            {
                var graphObject = marker as ObjectGraphType<object>;
                foreach (var field in graphObject.Fields)
                    AddField(field);
            }
        }
    }
}
