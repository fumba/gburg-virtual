﻿using System;

// PoIFilter Abstract Class
// Author: Kyle McCarty

/// <summary>
/// This class represents a filter object used to filter POIs.
/// Its only required class is method that tells whether a given
/// object is of interest and should be kept or not.
/// </summary>
public abstract class PoIFilter
{
    /// <summary>
    /// Method indicates whether an object should pass through the
    /// filter or be ignored.
    /// </summary>
    /// <param name="p">Represents the object being filtered.</param>
    /// <returns>Returns true if the object should be kept,
    /// false otherwise.</returns>
    public abstract bool IsValid(PoI p);
}
