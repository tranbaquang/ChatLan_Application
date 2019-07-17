package server;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Enumeration;
import java.util.Hashtable;
import java.lang.Thread;

import javax.print.attribute.standard.Severity;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import java.awt.Font;
import javax.swing.SwingConstants;
import javax.swing.ImageIcon;
import java.awt.Toolkit;
import java.awt.Window.Type;
import java.awt.Color;
import java.awt.color.*;

public class Server extends JFrame implements ActionListener {
	private JButton close;
	private ServerSocket server;
	public Hashtable<String, ThreadSever> listUser;
	private JTextField txtIPAddress;
	JTextArea user;
	private JTextField txtPortAddress;
	private JLabel lblIp;
	private JLabel lblPort;
	private JTextArea online;
	private JLabel lblDanhSchOnline;
//\	private int port;
	private JLabel label_2;
	private JButton start;

	// private String nickName;

//\	public int getPort() {
//\		return port;
//\	}
//
//\	public void setPort(int port) {
//\		this.port = port;
//\	}

	public Server() {
		super("SERVER CHAT");
		setIconImage(Toolkit.getDefaultToolkit()
				.getImage("/home/iot/eclipse-workspac/JavaSocket_ChatRomGui/src/image/chat.png"));
		setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
		this.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				// server.close();
				System.exit(0);
			}
		});

		setSize(534, 426);
		addItem();
		// go(port);
		setVisible(true);

	}

	private void addItem() {
		getContentPane().setLayout(null);

		JLabel label = new JLabel("Trang thai Server: \n");
		label.setFont(new Font("DejaVu Sans Mono", Font.BOLD, 13));
		label.setBounds(12, 55, 400, 15);
		getContentPane().add(label);
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(12, 75, 345, 270);
		getContentPane().add(scrollPane);

		user = new JTextArea();
		scrollPane.setViewportView(user);
		user.setForeground(new Color(255, 255, 255));
		user.setBackground(new Color(0, 102, 102));
		user.setColumns(20);
		user.setEditable(false);

		close = new JButton("Close");
		close.setBackground(new Color(255, 255, 255));
		close.setBounds(12, 357, 345, 25);
		close.addActionListener(this);
		getContentPane().add(close);

		txtIPAddress = new JTextField();
		txtIPAddress.setText("localhost/127.0.0.1");
		txtIPAddress.setHorizontalAlignment(SwingConstants.CENTER);
		txtIPAddress.setEditable(false);
		txtIPAddress.setBounds(279, 12, 124, 31);
		getContentPane().add(txtIPAddress);
		txtIPAddress.setColumns(10);

		txtPortAddress = new JTextField();
		txtPortAddress.setHorizontalAlignment(SwingConstants.CENTER);
		txtPortAddress.setColumns(10);
		txtPortAddress.setBounds(451, 12, 63, 31);
		getContentPane().add(txtPortAddress);

		lblIp = new JLabel("IP:");
		lblIp.setBounds(253, 20, 66, 15);
		getContentPane().add(lblIp);

		lblPort = new JLabel("PORT:");
		lblPort.setBounds(407, 20, 66, 15);
		getContentPane().add(lblPort);

		online = new JTextArea(10, 10);
		online.setEditable(false);
		online.setColumns(20);
		online.setBounds(380, 89, 134, 256);
		getContentPane().add(online);

		lblDanhSchOnline = new JLabel("Danh sach online");
		lblDanhSchOnline.setFont(new Font("DejaVu Sans Mono", Font.BOLD, 13));
		lblDanhSchOnline.setBounds(380, 71, 134, 15);
		getContentPane().add(lblDanhSchOnline);

		label_2 = new JLabel("");
		label_2.setIcon(new ImageIcon("/home/iot/eclipse-workspac/JavaSocket_ChatRomGui/src/image/chat.png"));
		label_2.setBounds(96, 0, 66, 51);
		getContentPane().add(label_2);

		start = new JButton("Start");
		start.addActionListener(this);
		start.setForeground(new Color(240, 255, 255));
		start.setBackground(new Color(0, 191, 255));
		start.setBounds(380, 357, 134, 25);
		getContentPane().add(start);

	}

	private void go(int port) {
		try {
			// port = StartServer.PORT;
			listUser = new Hashtable<String, ThreadSever>();
			server = new ServerSocket(port);
			user.append("[#] Server Chat hoat dong tai \ndia chi: " 
					+ txtIPAddress.getText() 
					+ ":" + port + "\n");
			
			int i = 1;
			while (true) {
				Socket client = server.accept();
				new ThreadSever(this, client);

				Date timeNow = new Date();
				DateFormat df = new SimpleDateFormat("hh:mm:ss");
				this.online.append("[" + df.format(timeNow) + "]: user #" + i++ + "\n");
			}
		} catch (IOException e) {
			user.append("Khong the khoi dong Server Chat \ntai PORT: " 
					+ Integer.parseInt(txtPortAddress.getText()) + "\n");
		}
	}

	public static void main(String[] args) {
		new Server();// .go(7777);
	}

	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == close) {
//*			try {
//*				 server.close();
//*			} catch (IOException e1) {
//*				user.append("Khong the dung may chu\n");
//*			}
			System.exit(0);
		} else if (e.getSource() == start) {
			if (txtPortAddress.getText().equals("")) {
				JOptionPane.showMessageDialog(this, "Ban chua nhap PORT !");
			} else {
				go(Integer.parseInt(txtPortAddress.getText()));
			}
		}

	}

	public void sendAll(String from, String msg) {
		Enumeration e = listUser.keys();
		String name = null;
		while (e.hasMoreElements()) {
			name = (String) e.nextElement();
			if (name.compareTo(from) != 0) {
				listUser.get(name).sendMSG("3", msg);

			}
		}
	}

	public void sendAllUpdate(String from) {
		Enumeration e = listUser.keys();
		String name = null;
		while (e.hasMoreElements()) {
			name = (String) e.nextElement();
			// System.out.println(name);
			if (name.compareTo(from) != 0)
				listUser.get(name).sendMSG("4", getAllName());
		}
	}

	public String getAllName() {
		Enumeration e = listUser.keys();
		String name = "";
		while (e.hasMoreElements()) {
			name += (String) e.nextElement() + "\n";
		}
		return name;
	}
}
