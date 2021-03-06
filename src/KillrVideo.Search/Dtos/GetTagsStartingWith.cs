﻿using System;

namespace KillrVideo.Search.Dtos
{
    /// <summary>
    /// Parameters for getting tags starting with specified text.
    /// </summary>
    [Serializable]
    public class GetTagsStartingWith
    {
        public string TagStartsWith { get; set; }
        public int PageSize { get; set; }
    }
}