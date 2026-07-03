public class Exercicio01 {
    public void executar() {
        System.out.println("=== EXERCÍCIO 01: ÁREA DO TRIÂNGULO ===");

        double base = 10.5;
        double altura = 5.2;

        double area = (base * altura) / 2;
        long areaArredondada = Math.round(area);

        System.out.println("Área exata: " + area);
        System.out.println("Área arrendondada " + areaArredondada);
    }
}
