﻿using System.Collections.Generic;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Controls.GalleryPages.DragAndDropGalleries
{
	[Preserve(AllMembers = true)]
	public class DragAndDropGallery : Shell
	{
		public DragAndDropGallery()
		{
			Device.SetFlags(new List<string> { ExperimentalFlags.DragAndDropExperimental, ExperimentalFlags.ShellUWPExperimental, ExperimentalFlags.ShapesExperimental });
			Items.Add(new EnablingAndDisablingGestureTests());
			Items.Add(new VariousDragAndDropPermutations());
			Items.Add(new DragAndDropBetweenLayouts());
			Items.Add(new DragAndDropEvents());
			Items.Add(new DragPaths());
		}
	}
}
