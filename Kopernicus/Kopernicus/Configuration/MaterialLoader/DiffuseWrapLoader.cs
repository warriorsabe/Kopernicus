// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        [RequireConfigType(ConfigType.Node)]
        public class DiffuseWrapLoader : DiffuseWrap
        {
            // Texture, default = "white" { }
            [ParserTarget("mainTex")]
            public Texture2DParser mainTexSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            [ParserTarget("mainTexScale")]
            private Vector2Parser mainTexScaleSetter
            {
                get { return mainTexScale; }
                set { mainTexScale = value; }
            }

            [ParserTarget("mainTexOffset")]
            private Vector2Parser mainTexOffsetSetter
            {
                get { return mainTexOffset; }
                set { mainTexOffset = value; }
            }

            // Main Color, default = (1,1,1,1)
            [ParserTarget("color")]
            public ColorParser colorSetter
            {
                get { return color; }
                set { color = value; }
            }

            // Diffuse, default = 2
            [ParserTarget("diff")]
            public NumericParser<float> diffSetter
            {
                get { return diff; }
                set { diff = value; }
            }

            // Constructors
            public DiffuseWrapLoader () : base() { }
            [Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.")]
            public DiffuseWrapLoader (string contents) : base (contents) { }
            public DiffuseWrapLoader (Material material) : base(material) { }
        }
    }
}
