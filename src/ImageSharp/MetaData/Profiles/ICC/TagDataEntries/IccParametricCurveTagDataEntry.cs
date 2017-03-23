﻿// <copyright file="IccParametricCurveTagDataEntry.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp
{
    /// <summary>
    /// The parametricCurveType describes a one-dimensional curve by
    /// specifying one of a predefined set of functions using the parameters.
    /// </summary>
    internal sealed class IccParametricCurveTagDataEntry : IccTagDataEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IccParametricCurveTagDataEntry"/> class.
        /// </summary>
        /// <param name="curve">The Curve</param>
        public IccParametricCurveTagDataEntry(IccParametricCurve curve)
            : this(curve, IccProfileTag.Unknown)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IccParametricCurveTagDataEntry"/> class.
        /// </summary>
        /// <param name="curve">The Curve</param>
        /// <param name="tagSignature">Tag Signature</param>
        public IccParametricCurveTagDataEntry(IccParametricCurve curve, IccProfileTag tagSignature)
            : base(IccTypeSignature.ParametricCurve, tagSignature)
        {
            this.Curve = curve;
        }

        /// <summary>
        /// Gets the Curve
        /// </summary>
        public IccParametricCurve Curve { get; }

        /// <inheritdoc />
        public override bool Equals(IccTagDataEntry other)
        {
            if (base.Equals(other) && other is IccParametricCurveTagDataEntry entry)
            {
                return this.Curve == entry.Curve;
            }

            return false;
        }
    }
}
