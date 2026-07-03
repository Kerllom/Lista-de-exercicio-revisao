public class Exercicio02 {
    public  void  executar() {
        System.out.println("\n=== EXERCÍCIO 02: HIPOTENUSA ===");

        double cateto1 = 3.0;
        double cateto2 = 4.0;

        double somaDosQuadrados = Math.pow(cateto1, 2) + Math.pow(cateto2, 2);
        double hipotenusa = Math.sqrt(somaDosQuadrados);

        System.out.println("A hipotenusa é: " + hipotenusa);
    }
}
