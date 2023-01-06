namespace Workhouse;
class Part{
    public int Id  {get;set;}
    public string? PartName{get;set;}

    public override string ToString()
    {
        return "Id :=> "+this.Id+"  PartName :=> "+this.PartName;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }

    public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }

    public override int GetHashCode()
    {
        return Id;
    }
}