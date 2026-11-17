namespace MyArrayHelperLibary
{
    public abstract class MyComparable
    {
        //This method is used to compare the current object with another object of the same type.
        //It returns an integer value that indicates the relative order of the objects being compared.
        //If the current object is less than the other object, it returns -1.
        //If the current object is equal to the other object, it returns 0.
        //If the current object is greater than the other object, it returns 1.
        public abstract int CompareTo(object? item);
    }
}
