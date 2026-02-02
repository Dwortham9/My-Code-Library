import java.io.*;
import java.net.*;
import java.util.Arrays;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
public class web_server
{

    public static void main(String[] args) 
    {
        int port = 80;
        
        try 
        {
            ServerSocket server = new ServerSocket(port);
           while(true)
           {
               //1
               System.out.println("Server waiting for a request on port "
                + port); 
               Socket socket = server.accept();
               System.out.println("Request accepted from " 
                        + socket.getInetAddress());
              //2 
               InputStream is;
                is = socket.getInputStream();
                
                InputStreamReader isr = new InputStreamReader(is);
                BufferedReader reader = new BufferedReader(isr);
                
                String line = reader.readLine();
                while (! line.isEmpty())
                {
                    System.out.println("read: " + line);
                    line = reader.readLine();
                }
                //3
                Date now = new Date();
                String response;
                response = "HTTP/1.1 200 OK\r\n\r\n";
                response += "<h1>Java server responded!</h1>";
                response += "\n<p>" + now + "</p>\n";
                response +="response += \"\\n<img src=\"https://www.rose.edu/media/7894/rsc-stkwordmark-blue.jpg\" width=\"500\" height=\"600\">\\n\";";
                System.out.println("Sending response.");
                System.out.println(response);
                //4
                OutputStream os = socket.getOutputStream();
                byte[] data = response.getBytes("UTF-8");
                System.out.println(Arrays.toString(data));
                os.write(data);
                
                System.out.println(data.length + " bytes sent");
                
                socket.close();
                System.out.println("Socket closed");
           } 
        } 
        catch (IOException ex) 
        {
            Logger.getLogger(Homework14.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}

