




import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.pdf.PdfWriter;
import com.itextpdf.tool.xml.XMLWorkerHelper;
import java.io.FileNotFoundException;
import java.util.logging.Level;
import java.util.logging.Logger;
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author mario
 */
public class NewJFrame extends javax.swing.JFrame {

    /**
     * Creates new form NewJFrame
     */
    public NewJFrame() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jToggleButton1 = new javax.swing.JToggleButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jToggleButton1.setText("jToggleButton1");
        jToggleButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jToggleButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(146, 146, 146)
                .addComponent(jToggleButton1)
                .addContainerGap(149, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(101, 101, 101)
                .addComponent(jToggleButton1)
                .addContainerGap(176, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jToggleButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jToggleButton1ActionPerformed


        
        
        
      // step 1
        Document document = new Document();
        // step 2
        PdfWriter writer = null;
        try {
            writer = PdfWriter.getInstance(document, new FileOutputStream("pdf.pdf"));
        } catch (FileNotFoundException ex) {
            Logger.getLogger(NewJFrame.class.getName()).log(Level.SEVERE, null, ex);
        } catch (DocumentException ex) {
            Logger.getLogger(NewJFrame.class.getName()).log(Level.SEVERE, null, ex);
        }
        // step 3
        document.open();
        try {
            // step 4
            XMLWorkerHelper.getInstance().parseXHtml(writer, document, 
                    new FileInputStream("index.html"));
        } catch (IOException ex) {
            Logger.getLogger(NewJFrame.class.getName()).log(Level.SEVERE, null, ex);
        }
        //step 5
         document.close();
 
        System.out.println( "PDF Created!" );
        

//Document document = new Document(PageSize.A4, 36, 36, 36, 36);
//
//    try
//    {
//        OutputStream file = new FileOutputStream(new File("HTMLtoPDF125.pdf"));
//        PdfWriter writer = PdfWriter.getInstance(document, file);
//        document.open();
//
//        
//                           
//        StringBuilder htmlString = new StringBuilder();
//                                                 String Dato= "mira que esto es maravilla";
////						htmlString.append(new String("<html><head><title>"+Dato+"</title><style type=\"text/css\">body,html{border:0px}h1,h2,h3,h4,h5,h6{font-family:Arial,Helvetica,sans-serif}body,p{font-family:\"verdana\",tahoma,arial,sans-serif}code{font-family:\"Courier New\",Courier,monospace}body{background-color:#FFE;font-family:\"verdana\",tahoma,arial,sans-serif}p{font-size:11px;font-family:\"verdana\",tahoma,arial,sans-serif;color:#040404;background-color:#FFE;margin-top:5px;margin-bottom:8px;margin-left:10px}h1{font-size:17px;color:#FFA500;margin-bottom:10px;background-color:#00E;padding-top:6px;padding-bottom:7px;padding-left:10px}h2{font-size:15px;color:#05A;margin-bottom:10px;margin-top:16px;background-color:#FC6;padding-top:0px;padding-bottom:2px;padding-left:10px}h3{font-size:15px;color:#600;margin-bottom:8px;margin-top:15px}h4{font-size:12px;color:black;margin-bottom:8px;margin-top:15px;margin-left:8px;font-style:normal}code{font-size:12px;margin-left:16px;padding-left:16px}hr{height:0px;noshade:true;border:1;width:100%}.pError{font-size:11px;font-family:\"verdana\",tahoma,arial,sans-serif;color:red;background-color:#FFE;margin-top:5px;margin-bottom:8px;margin-left:10px}.pSkipped_PrevTaskFailed{font-size:11px;font-family:\"verdana\",tahoma,arial,sans-serif;color:#FF9D8B;background-color:#FFE;margin-top:5px;margin-bottom:8px;margin-left:10px}.pSkipped_DateNotInRange{font-size:11px;font-family:\"verdana\",tahoma,arial,sans-serif;color:#00BFFF;background-color:#FFE;margin-top:5px;margin-bottom:8px;margin-left:10px}.pAbort{font-size:11px;font-family:\"verdana\",tahoma,arial,sans-serif;color:#FFA500;background-color:#FFE;margin-top:5px;margin-bottom:8px;margin-left:10px}.pNeutral{font-size:11px;font-family:\"verdana\",tahoma,arial,sans-serif;color:silver;background-color:#FFE;margin-top:5px;margin-bottom:8px;margin-left:10px}.pSummary{font-size:11px;font-family:\"verdana\",tahoma,arial,sans-serif;color:blue;background-color:#FFE;margin-top:0px;margin-bottom:2px;margin-left:10px}.tableHead{font-size:15px;font-weight:bold;color:#05A;margin-bottom:10px;margin-top:16px;background-color:#FC6;padding-top:0px;padding-bottom:2px}.tdPadding{padding-top:0px;padding-bottom:0px;padding-left:7px;padding-right:7px}.h2RowHead{background-color:#999;color:#eee;font-weight:bold}.tableContent{font-size:11px;font-weight:normal;color:black;margin-bottom:10px;margin-top:16px;background-color:#FC6;padding-top:0px;padding-bottom:2px}</style></head><body><table class=\"tableHead\" width=\"100%\"><tr><td align=\"left\" class=\"tdPadding\">Summary log</td></tr><tr class=\"tableContent\"><td align=\"left\" class=\"tdPadding\"><b>User's account name: </b>First.Last</td><td align=\"center\" class=\"tdPadding\"><b>Server: </b>someServer</td><td align=\"right\" class=\"tdPadding\"><b>Execution date: </b>22.01.2015 04:49:37:918</td></tr></table><table width=\"100%\"><tr><td class=\"h2RowHead\">Running Process for [22.01.2015]</td></tr></table><p><b><h4>MAIN</h4></b></p><hr /><p class=\"pError\">(1) Task: <i>StopOnFailure1</i> invoked at 22.01.2015 04:49:37:934 >> <b>FAILURE!</b> Task finished with return code: 13. Component: StopOnFailure1 timed out.</p> <br /><p>Record Statistics: Processed: 68680 | Filtered: 0 | Failed: 0 | Running time: 00:00:05</p><hr /><p class=\"pError\">(2) Task: <i>DataFlow1</i> invoked at 22.01.2015 04:49:43:254 >> <b>FAILURE!</b> Task finished with return code: 4. Failed to load Component from file \"C:docAPIAPI.txt\". Reason: Component now found.</p> <br /><p class=\"pError\">(3) Task: <i>DataFlow2</i> invoked at 22.01.2015 04:49:43:300 >> <b>FAILURE!</b> Reason: Current object state [Ready] doesn't allow to stop this component.</p> <br /><table width=\"100%\"><tr><td class=\"h2RowHead\">Process execution summary:</td></tr></table><p>Active Tasks: 3</p> <br /> Executed Tasks: 3<br /> Successful Tasks: 0<br /> Failed Tasks: 3<br /> Skipped Tasks based on calendar: 0<br /> Skipped Tasks based on result of previous Task: 0<br /> <b>Process completed successfully. Elapsed time: "+Dato+"</b></body></html>"));
//						
//						htmlString.append(new String("<html><head><title>Summary log</title><style type=\"text/css\">body, html{border: 0px}h1, h2, h3, h4, h5, h6{font-family: Arial, Helvetica, sans-serif}body, p{font-family: \"verdana\", tahoma, arial, sans-serif}code{font-family: \"Courier New\", Courier, monospace}body{font-family: \"verdana\", tahoma, arial, sans-serif;}p{font-size: 11px; font-family: \"verdana\", tahoma, arial, sans-serif; color: #040404; background-color: #FFFFEE; margin-top: 5px; margin-bottom: 8px; margin-left: 10px;}h1{font-size: 17px; color: #FFA500; margin-bottom: 10px; background-color: #0000EE; padding-top:6px; padding-bottom:7px; padding-left:10px;}h2{font-size: 15px; color: #0055AA; margin-bottom: 10px; margin-top: 16px; background-color:#FFCC66; padding-top:0px; padding-bottom:2px; padding-left:10px;}h3{font-size: 15px; color: #660000; margin-bottom: 8px; margin-top: 15px;}h4{font-size: 12px; color: black; margin-bottom: 8px; margin-top: 15px; margin-left: 8px; font-style: normal;}code{font-size: 12px; margin-left: 16px; padding-left:16px}hr{height: 0px; noshade: true; border: 1; width: 100%;}/* FFCC66 FFEE99 */ .pError{font-size: 11px; font-family: \"verdana\", tahoma, arial, sans-serif; color: red; background-color: #FFFFEE; margin-top: 5px; margin-bottom: 8px; margin-left: 10px;}.pSkipped_PrevTaskFailed{/* Process Manager: Task skipped since previous task failed*/ font-size: 11px; font-family: \"verdana\", tahoma, arial, sans-serif; color: #FF9D8B; /*Light red shade color*/ background-color: #FFFFEE; margin-top: 5px; margin-bottom: 8px; margin-left: 10px;}.pSkipped_DateNotInRange{/* Process Manager: Task skipped since run date not in range*/ font-size: 11px; font-family: \"verdana\", tahoma, arial, sans-serif; color: #00BFFF; /*Light blue shade color*/ background-color: #FFFFEE; margin-top: 5px; margin-bottom: 8px; margin-left: 10px;}.pAbort{/* Process Manager: Task is aborted*/ font-size: 11px; font-family: \"verdana\", tahoma, arial, sans-serif; color: #FFA500; /*Orange color*/ background-color: #FFFFEE; margin-top: 5px; margin-bottom: 8px; margin-left: 10px;}.pNeutral{font-size: 11px; font-family: \"verdana\", tahoma, arial, sans-serif; color: silver; background-color: #FFFFEE; margin-top: 5px; margin-bottom: 8px; margin-left: 10px;}.pSummary{font-size: 11px; font-family: \"verdana\", tahoma, arial, sans-serif; color: blue; background-color: #FFFFEE; margin-top: 0px; margin-bottom: 2px; margin-left: 10px;}.tableHead{font-size: 15px; font-weight: bold; color: #0055AA; margin-bottom: 10px; margin-top: 16px; background-color:#FFCC66; padding-top:0px; padding-bottom:2px; border-radius: 5px; border: red 5px solid; /*padding-left:10px;*/}.tdPadding{padding-top:0px;padding-bottom:0px;padding-left:7px;padding-right:7px;}.h2RowHead{background-color: #999999; color: #eeeeee; font-weight: bold}.tableContent{font-size: 11px; font-weight: normal; color: black; margin-bottom: 10px; margin-top: 16px; background-color:#FFCC66; padding-top:0px; padding-bottom:2px; /* padding-left:10px; */}</style></head><body><table class=\"tableHead\" width=\"100%\"><tr><td align=\"left\" class=\"tdPadding\">Summary log</td></tr><tr class=\"tableContent\"> <td align=\"left\" class=\"tdPadding\"><b>User's account name: </b>First.Last</td><td align=\"center\" class=\"tdPadding\"><b>Server: </b>someServer</td><td align=\"right\" class=\"tdPadding\"><b>Execution date: </b>22.01.2015 04:49:37:918</td></tr></table> <table width=\"100%\"><tr><td class=\"h2RowHead\">Running Process for [22.01.2015] </td></tr></table><p><b><h4>MAIN</h4></b></p><hr/><p class=\"pError\">(1) Task: <i>StopOnFailure1</i> invoked at 22.01.2015 04:49:37:934 >> <b>FAILURE!</b> Task finished with return code: 13. Component: StopOnFailure1 timed out.</p><br/><p>Record Statistics: Processed: 68680 | Filtered: 0 | Failed: 0 | Running time: 00:00:05</p><hr/><p class=\"pError\">(2) Task: <i>DataFlow1</i> invoked at 22.01.2015 04:49:43:254 >> <b>FAILURE!</b> Task finished with return code: 4. Failed to load Component from file \"C:\\doc\\API\\API.txt\". Reason: Component now found.</p><br/><p class=\"pError\">(3) Task: <i>DataFlow2</i> invoked at 22.01.2015 04:49:43:300 >> <b>FAILURE!</b> Reason: Current object state [Ready] doesn't allow to stop this component.</p><br/><table width=\"100%\"><tr><td class=\"h2RowHead\">Process execution summary:</td></tr></table><p>Active Tasks: 3</p><br/>Executed Tasks: 3<br/>Successful Tasks: 0<br/>Failed Tasks: 3<br/>Skipped Tasks based on calendar: 0<br/>Skipped Tasks based on result of previous Task: 0<br/><b>Process completed successfully. Elapsed time: 5 seconds.</b></body></html>"));
////                                                
////						htmlString.append(new String("<tr><td>JavaCodeGeeks</td><td><a href='examples.javacodegeeks.com'>JavaCodeGeeks</a> </td></tr>"));				
////						htmlString.append(new String("<tr> <td> Google Here </td> <td><a href='www.google.com'>Google</a> </td> </tr></table></body></html>"));
////										
////						
//
//						InputStream is = new ByteArrayInputStream(htmlString.toString().getBytes());
//                                                               Image image1 = Image.getInstance("img.jpg");
//                                         image1.setAbsolutePosition(10f, 670f);
//                                        document.add(image1); 
//                                      File htmlSource = new File("/index.html");
//                                      document.add((Element) htmlSource);
//                                        
//
//						XMLWorkerHelper.getInstance().parseXHtml(writer, document, is);
//						document.close();
//						file.close();
//                     
//            
//        
//
//      
//        System.out.print("HECHO");
//    } catch(Exception e){
//      e.printStackTrace();
//    }
//

       
        // TODO add your handling code here:
    }//GEN-LAST:event_jToggleButton1ActionPerformed

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
            java.util.logging.Logger.getLogger(NewJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(NewJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(NewJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(NewJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new NewJFrame().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JToggleButton jToggleButton1;
    // End of variables declaration//GEN-END:variables
}
