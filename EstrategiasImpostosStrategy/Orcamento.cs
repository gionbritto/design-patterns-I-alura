public class Orcamento(double valor)
{  
    public double Valor { get; private set; } = valor;
    public List<ItemPedido> Itens { get; private set; } = [];

    public void AdicionarItem(ItemPedido itemPedido){
        Itens.Add(itemPedido);
    }
}