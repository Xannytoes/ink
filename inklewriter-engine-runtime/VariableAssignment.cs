﻿using Newtonsoft.Json;
using System.ComponentModel;

namespace Inklewriter.Runtime
{
    // The value to be assigned is popped off the evaluation stack, so no need to keep it here
    public class VariableAssignment : Runtime.Object
    {
        [JsonProperty("var")]
        [UniqueJsonIdentifier]
        public string variableName { get; protected set; }

        [JsonProperty("new")]
        [DefaultValue(false)]
        public bool isNewDeclaration { get; protected set; }

        public VariableAssignment (string variableName, bool isNewDeclaration)
        {
            this.variableName = variableName;
            this.isNewDeclaration = isNewDeclaration;
        }

        // Require default constructor for serialisation
        public VariableAssignment() : this(null, false) {}

        public override string ToString ()
        {
            return "VarAssign to " + variableName;
        }
    }
}
