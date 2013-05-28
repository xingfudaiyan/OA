using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using CanYouLib.Exceptions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace CanYou
{
    public class EntityObject
    {
        public EntityObject DeepClone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0L;
                return (EntityObject)formatter.Deserialize(stream);
            }
        }

        public virtual object GetKey()
        {
            throw new AppException("GetKey()没有被" + this.GetType().ToString() + "重载");
        }

        public virtual void Save()
        {
            throw new AppException("Save()没有被" + this.GetType().ToString() + "重载");
        }

        public virtual void Delete()
        {
            throw new AppException("Delete()没有被" + this.GetType().ToString() + "重载");
        }

        public override bool Equals(object right)
        {
            if (right == null)
                return false;
            if (object.ReferenceEquals(this, right))
                return true;
            if (this.GetType() != right.GetType())
                return false;
            XmlDocument leftXml = Serialize(this);
            XmlDocument rightXml = Serialize(right);

            return leftXml.InnerXml == rightXml.InnerXml; 
        }


        private XmlDocument Serialize(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlDocument doc = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(stream, obj);
                stream.Seek(0, SeekOrigin.Begin);
                doc.Load(stream);

                return doc;
            }
        }
 

    }
}
