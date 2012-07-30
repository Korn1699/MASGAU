﻿using System.IO;
using System;
using System.Xml;
using MVC;
using XmlData;
namespace MASGAU.Location.Holders {
    public class LocationPathHolder : ALocationHolder {
        // Used when dealing with a path
        // ONLY holds the name of the environment variable or wahtever used to figure out the root
        public EnvironmentVariable rel_root;

        // Holds only the relative path from the root
        public string Path;

        public LocationPathHolder() : base() { }

        public LocationPathHolder(XmlElement element)
            : base(element) {
            foreach (XmlAttribute attrib in element.Attributes) {
                if (attributes.Contains(attrib.Name))
                    continue;

                switch (attrib.Name) {
                    case "ev":
                        this.rel_root = parseEnvironmentVariable(attrib.Value);
                        break;
                    case "path":
                        this.Path = attrib.Value;
                        break;
                    default:
                        throw new NotSupportedException(attrib.Name);
                }
            }
        }

        public LocationPathHolder(LocationPathHolder copy_me)
            : base(copy_me) {
            rel_root = copy_me.rel_root;
            Path = copy_me.Path;
        }

        public override int CompareTo(AModelItem<StringID> comparable) {
            LocationPathHolder location = (LocationPathHolder)comparable;
            int result = compare(this.rel_root, location.rel_root);
            if (result == 0)
                result = compare(this.Path, location.Path);

            return result;
        }


        public override string ToString() {
            if (Path == null)
                return rel_root.ToString();
            else
                return System.IO.Path.Combine(rel_root.ToString(), Path);
        }

        public XmlElement createXml(Game parent) {
            if(this.xml!=null)
                return this.xml;

            xml = parent.createElement("path");
            parent.addAtribute(xml, "ev", this.rel_root.ToString().ToLower());
            parent.addAtribute(xml, "path", this.Path);

            return this.xml;
        }

    }
}
