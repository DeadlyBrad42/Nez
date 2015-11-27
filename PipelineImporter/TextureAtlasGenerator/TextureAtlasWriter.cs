﻿using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using System.ComponentModel;
using System;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using Nez.TextureAtlases;


namespace Nez.TextureAtlasGenerator
{
	[ContentTypeWriter]
	public class TextureAtlasWriter : ContentTypeWriter<TextureAtlasContent>
	{
		protected override void Write( ContentWriter output, TextureAtlasContent value )
		{
			// Write out all the members of 'value'                
			output.WriteObject( value.texture );
			output.WriteObject( value.spriteRectangles );
			output.WriteObject( value.spriteNames );
		}


		public override string GetRuntimeType( TargetPlatform targetPlatform )
		{
			return typeof( TextureAtlas ).AssemblyQualifiedName;
		}


		public override string GetRuntimeReader( TargetPlatform targetPlatform )
		{
			// This is the full namespace path and class name of the reader, along with the assembly name which is the project name by default.
			return typeof( TextureAtlasReader ).AssemblyQualifiedName;
		}
	}
}