// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Abstract base class for skills. </summary>
    public partial class Skill
    {
        /// <summary> Initializes a new instance of Skill. </summary>
        public Skill()
        {
            OdataType = null;
        }
        public string OdataType { get; internal set; }
        /// <summary> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character &apos;#&apos;. </summary>
        public string? Name { get; set; }
        /// <summary> The description of the skill which describes the inputs, outputs, and usage of the skill. </summary>
        public string? Description { get; set; }
        /// <summary> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </summary>
        public string? Context { get; set; }
        /// <summary> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </summary>
        public ICollection<InputFieldMappingEntry> Inputs { get; set; } = new List<InputFieldMappingEntry>();
        /// <summary> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </summary>
        public ICollection<OutputFieldMappingEntry> Outputs { get; set; } = new List<OutputFieldMappingEntry>();
    }
}