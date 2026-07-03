public class Exercicio03 {
    public void executar() {
        System.out.println("\n=== EXERCÍCIO 03: VOLUME DA ESFERA ===");

        double raio = 5.0;

        // Lembrando: 4.0 / 3.0 para o Java entender que é uma divisão decimal
        double volume = (4.0 / 3.0) * Math.PI * Math.pow(raio, 3);

        System.out.printf("O volume da esfera é: %.2f\n", volume);
    }
}
