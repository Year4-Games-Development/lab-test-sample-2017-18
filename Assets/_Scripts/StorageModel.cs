
public class StorageModel
{
    private int units;
    public int Capacity { get; set; }
    public int MaxDelivery { get; set; }
    public float NearlyFullPercentage { get; set; }

    public StorageModel()
    {
        this.units = 0;
        this.Capacity = 100;
        this.MaxDelivery = 20;
        this.NearlyFullPercentage = 0.75F;
    }

    public int GetUnits()
    {
        return this.units;
    }

    public bool IsNearlyFull()
    {
        int nearlyFullUnits = (int)(NearlyFullPercentage * Capacity);
        return (this.units >= nearlyFullUnits);
    }


    public bool Deliver(int unitsDelivered)
    {
        if((unitsDelivered <= MaxDelivery) && (unitsDelivered + this.units <= Capacity)){
            this.units += unitsDelivered;
            return true;
        }

        // if got this far, failure ...
        return false;
    }

}
