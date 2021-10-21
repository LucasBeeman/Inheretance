namespace Inheretance
{
    interface IAutomobile<T>
    {
        bool Equals(T obj);
        void FillGas(double amount);
    }
}
