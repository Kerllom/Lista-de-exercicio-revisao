public class Exercicio04 {
    public void executar() {
        System.out.println("\n=== EXERCÍCIO 04: DISTÂNCIA ENTRE PONTOS ===");

        double x1 = 1.0, y1 = 2.0;
        double x2 = 4.0, y2 = 6.0;

        double subX = Math.pow((x2 - x1), 2);
        double subY = Math.pow((y2 - y1), 2);

        double distancia = Math.sqrt(subX + subY);

        System.out.printf("A distância entre os pontos é: ", distancia);
    }
}
