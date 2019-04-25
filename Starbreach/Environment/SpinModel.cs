// Copyright (c) Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;
using System.Collections.Generic;
using System.Linq;
using Xenko.Core.Mathematics;
using Xenko.Engine;

namespace Starbreach.Environment
{
    public class SpinModel : SyncScript
    {
        private float angle;

        public float TurnPerSecond { get; set; } = 1.0f;
        public override void Update()
        {
            var radPerSecond = TurnPerSecond * MathUtil.TwoPi;
            var radToAdd = radPerSecond * Game.UpdateTime.Elapsed.TotalSeconds;
            angle = (float)(angle + radToAdd);
            Entity.Transform.Rotation = Quaternion.RotationY(angle);
        }
    }
}