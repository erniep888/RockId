using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Test.Common
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public AutoMoqDataAttribute() : base (new Fixture().Customize(new AutoMoqCustomization()))
#pragma warning restore CS0618 // Type or member is obsolete
        {

        }
    }
}
