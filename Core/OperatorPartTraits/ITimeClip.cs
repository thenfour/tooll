// Copyright (c) 2016 Framefield. All rights reserved.
// Released under the MIT license. (see LICENSE.txt)

using System;
using System.Collections.Generic;
using SharpDX;

namespace Framefield.Core.OperatorPartTraits
{

    public interface ITimeClip
    {
        double StartTime { get; set; }
        double EndTime { get; set; }
        double SourceStartTime { get; set; }
        double SourceEndTime { get; set; }
        int Layer { get; set; }
    }

  public interface ITimeClipColor
  {
    Color4 BackgroundColor { get; set; }
    Color4 ForegroundColor { get; set; }
  }

  public class DefaultTimeClipColor : ITimeClipColor
  {
    //public static DefaultTimeClipColor Instance = new DefaultTimeClipColor();

    Color4 _backgroundColor = new Color4(0, 1.0f, 1.0f, .6f);
    Color4 _foregroundColor = new Color4(1.0f, 1.0f, 1.0f, 1.0f);

    public Color4 BackgroundColor
    {
      get => _backgroundColor;
      set { _backgroundColor = value; }
    }
    public Color4 ForegroundColor
    {
      get => _foregroundColor;
      set { _foregroundColor = value; }
    }
  }

}
