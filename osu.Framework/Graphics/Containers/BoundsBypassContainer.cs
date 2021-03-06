﻿//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using OpenTK;

namespace osu.Framework.Graphics.Containers
{
    /// <summary>
    /// A container that always considers input to be inside it.
    /// </summary>
    class BoundsBypassContainer : Container
    {
        internal override bool Contains(Vector2 screenSpacePos) => true;
    }
}
