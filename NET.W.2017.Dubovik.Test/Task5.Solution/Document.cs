﻿using System;
using System.Collections.Generic;

namespace Task5
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<DocumentPart>(parts);
        }

        public string Convert(ITransformer transformer)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.Transform(transformer)}\n";
            }

            return output;
        }

    }
}
