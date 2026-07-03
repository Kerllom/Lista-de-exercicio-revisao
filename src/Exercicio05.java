public class Exercicio05 {
    public void executar() {
        System.out.println("\n=== EXERCÍCIO 05: NÚMERO ALEATÓRIO ===");

        int numeroAleatorio = (int) (Math.random() * 100) + 1;

        System.out.println("Número aleatório gerado (1 a 100): " + numeroAleatorio);
    }
}
