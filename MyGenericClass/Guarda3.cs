using System;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T item1;
        private T item2;
        private T item3;

        // Construtor vazio que inicializa as variáveis com valores por omissão
        public Guarda3()
        {
            item1 = default(T);
            item2 = default(T);
            item3 = default(T);
        }

        // Método para obter um item por índice
        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return item1;
                case 1:
                    return item2;
                case 2:
                    return item3;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        // Método para definir um item por índice
        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    item1 = item;
                    break;
                case 1:
                    item2 = item;
                    break;
                case 2:
                    item3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}