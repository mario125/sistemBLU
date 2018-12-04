package interfas;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import consola.Consola;
import funcion.Funcion;
import javax.swing.JFrame;
import org.math.plot.*;
import metodos.Base;
/**
 *
 * @author mario
 */
public class INTERFAS extends javax.swing.JFrame {

    /**
     * Creates new form INTERFAS
     */
     public Funcion funcion;
    public boolean fraccion = false;
    public int decimales = 2;
    public int espaciado = 0;
    metodos.Base bs = new Base();
      int n =50;
     double[] Y = new double[n + 1];
        double[] X = new double[n + 1];
     
    public INTERFAS() {
        
        initComponents();
    }
    //_______________________________________________________________kuta 4to orden______________________
     public double orden4(Funcion funcion, double x0, double y0, double h) {
        double F1 = funcion.evaluar(x0, y0);
        double F2 = funcion.evaluar(x0 + 0.5 * h, y0 + 0.5 * h * F1);
        double F3 = funcion.evaluar(x0 + 0.5 * h, y0 + 0.5 * h * F2);
        double F4 = funcion.evaluar(x0 + h, y0 + h * F3);
        //System.out.println(+F1);
        //System.out.println(+F2);
        //System.out.println(+F3);
        //System.out.println(+F4);
 
        textarea.append("" + bs.redondear(y0) + " + (" + bs.redondear(h) + " * (" + bs.redondear(F1) + " + 2 * (" + bs.redondear(F2) + " + " + bs.redondear(F3) + ") + " + bs.redondear(F4) + ")) / 6 = " +bs.redondear(y0 + (h * (F1 + 2 * (F2 + F3) + F4)) / 6));
textarea.append(System.getProperty("line.separator"));
//        interfas.INTERFAS in = new INTERFAS();
//        in.show();
//        in.tarea("joder");
        return y0 + (h * (F1 + 2 * (F2 + F3) + F4)) / 6.0;
    }

     public double[] evaluar(Funcion funcion, double x0, double y0, double xn, int n) {

        System.out.println("x0: " + x0);
        System.out.println("y0: " + y0);
        System.out.println("xn: " + xn);
        System.out.println(" n: " + n);
        System.out.println();

       

        bs.inicializar(X, x0);
        double h = (xn - x0) / n;
        Y[0] = y0;
        X[0] = x0;
        for (int i = 0; i < n; i++) {
            
            textarea.append("I=" + i); 
            textarea.append(System.getProperty("line.separator"));
            System.out.println("I=" + i);
            y0 = this.orden4(funcion, x0, y0, h);
            x0 += h;
            X[i + 1] = x0;
            Y[i + 1] = y0;
        }

        System.out.println("");
        System.out.println("Resultado:");
        
         for (int j = 0; j < X.length; j++) {

  textarea.append("["+ bs.redondear(X[j], 6, 15, true)+"]"+"-"+"["+bs.redondear(Y[j], 6, 15, true)+"]\n");  
//  textarea.append("|"+ bs.redondear(Y[j], 6, 20, false));
          

        }
//          textarea.append(System.getProperty("line.separator"));
//           for (int j = 0; j < Y.length; j++) {
//
//        textarea.append("|"+ bs.redondear(Y[j], 6, 20, false)); 
//          
//
//        }
         
      // reportarcoordenadas(X, Y);



        return Y;
    }
      public int getEspaciado(double[][] matriz) {
        int tamano = 0;
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                int redondeado = (bs.redondear(matriz[i][j])).length();
                tamano = redondeado > tamano ? redondeado : tamano;
            }
        }

        return tamano + 2;
    }
public void reportarcoordenadas(double[] x, double[] y) {

        int n = x.length;
        double[][] coordenadas = new double[2][n];

        for (int j = 0; j < n; j++) {


            coordenadas[0][j] = x[j];
            coordenadas[1][j] = y[j];

        }

        int ancho = this.getEspaciado(coordenadas);

        System.out.println("");


        System.out.print("\n");

        for (int i = 0; i < coordenadas.length; i++) {

            if (i == 0) {
                textarea.append(bs.redondear("X", 6, true));
                System.out.print(bs.redondear("X", 6, true));
            } else {
                textarea.append(bs.redondear("f(x)", 6, true));
                System.out.print(bs.redondear("f(x)", 6, true));
            }

            this.reportarFilacoordenadas(coordenadas[i], ancho);

        }

        System.out.println("");



    }
  public void reportarFilacoordenadas(double[] fila, int ancho) {

        System.out.print("[");
        textarea.append("[");
        int n = fila.length;
        for (int i = 0; i < n; i++) {
            double numero = fila[i];

            if (i != 0) {

                System.out.print("|" + bs.redondear(numero, ancho, true));
                textarea.append("|"+ bs.redondear(numero, ancho, true));

            } else {
                System.out.print(bs.redondear(numero, ancho, true));
                textarea.append(bs.redondear(numero, ancho, true));

            }

        }

        System.out.print("]");
        textarea.append(System.getProperty("line.separator"));
        System.out.print("\n");

    }
      public void consola() {

        Consola consola = new Consola();
        String funcion_cadena = "1-y^2";
        double x0 = 0;
        double y0 = 0;
        double xn = 1;
         n = 50;


        boolean fraccion = true;
        int decimales = 2;

        this.fraccion = fraccion;
        this.decimales = decimales;

        consola.limpiarPantalla();
        Funcion funcion = new Funcion(funcion_cadena);
        this.evaluar(funcion, x0, y0, xn, n);

    }
public void tarea( String dato){
    textarea.append(dato); 
textarea.append(System.getProperty("line.separator")); // Esto para el salto de línea 
textarea.append("fff"); 
textarea.append(System.getProperty("line.separator")); // Esto para el salto de línea 
textarea.append("fff"); 
textarea.append(System.getProperty("line.separator")); // Esto para el salto de línea 
}
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jButton1 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        textarea = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jButton1.setText("jButton1");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        textarea.setColumns(20);
        textarea.setRows(5);
        jScrollPane1.setViewportView(textarea);

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 686, Short.MAX_VALUE)
                .addContainerGap())
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addComponent(jButton1)
                .addGap(0, 0, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 378, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
consola();
//textarea.append("fff"); 
//textarea.append(System.getProperty("line.separator")); // Esto para el salto de línea 
//textarea.append("fff"); 
//textarea.append(System.getProperty("line.separator")); // Esto para el salto de línea 
//textarea.append("fff"); 
//textarea.append(System.getProperty("line.separator")); // Esto para el salto de línea 

  
  double[] x = X;
  double[] y = Y;
 
  Plot2DPanel plot = new Plot2DPanel();
 

  plot.addLinePlot("my plot", x, y);
 

  JFrame frame = new JFrame("a plot panel");
  frame.setContentPane(plot);
  frame.setVisible(true);
       
    }//GEN-LAST:event_jButton1ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(INTERFAS.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(INTERFAS.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(INTERFAS.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(INTERFAS.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new INTERFAS().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    public static javax.swing.JTextArea textarea;
    // End of variables declaration//GEN-END:variables
}
