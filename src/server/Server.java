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
import java.util.Enumeration;
import java.util.Hashtable;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import java.awt.Font;
import javax.swing.SwingConstants;
import javax.swing.ImageIcon;
import java.awt.Toolkit;
import java.awt.Color;
import javax.swing.UIManager;
import java.awt.Dialog.ModalExclusionType;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;

public class Server extends JFrame implements ActionListener {

	private JButton close;
	private ServerSocket server;
	public Hashtable<String, ThreadSever> listUser;
	private JTextField txtIPAddress;
	JTextArea user;
	private JTextField txtPortAddress;
	private JLabel lblIp;
	private JLabel lblPort;
	static JTextArea online;
	private JLabel lblDanhSchOnline;
	private JButton start;
	public static String name;
	private JButton button;

//	public void setPort(int port) {
//		port = Integer.parseInt(txtPortAddress.getText());
//		this.port = port;
//	}
//
//	public int getPort() {
//		return port;
//	}

	public Server() {
		super("SERVER CHAT");
		setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
		
		setIconImage(Toolkit.getDefaultToolkit()
				.getImage("/home/iot/eclipse-workspac/JavaSocket_ChatRomGui/src/image/chat.png"));
		this.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});

		setSize(595, 426);
		addItem();
		setVisible(true);

	}

// Khoi tao giao dien
	int i, j = 0;
	private JLabel label_1;
	private void addItem() {
		getContentPane().setLayout(null);

		button = new JButton("*");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if(j%2 == 0) {
					button.setBackground(new Color(0, 102, 102));
					user.setForeground(new Color(0, 102, 102));
					user.setBackground(new Color(255, 255, 255));
					j++;
				} else {
					button.setBackground(new Color(255, 255, 255));
					user.setForeground(new Color(255, 255, 255));
					user.setBackground(new Color(0, 102, 102));
					j++;
				}
			}
		});
		button.setBackground(new Color(255, 255, 255));
		button.setBounds(352, 82, 10, 9);
		getContentPane().add(button);

		JLabel label = new JLabel("Trang thai Server: \n");
		label.setFont(new Font("DejaVu Sans Mono", Font.BOLD, 13));
		label.setBounds(12, 62, 400, 15);
		getContentPane().add(label);
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(12, 82, 350, 263);
		getContentPane().add(scrollPane);
		
				user = new JTextArea();
				scrollPane.setViewportView(user);
				user.setForeground(new Color(255, 255, 255));
				user.setBackground(new Color(0, 102, 102));
				user.setColumns(20);
				user.setEditable(false);

		close = new JButton("Close");
		close.setBackground(new Color(255, 255, 255));
		close.setBounds(50, 357, 312, 25);
		close.addActionListener(this);
		getContentPane().add(close);

		txtIPAddress = new JTextField();
		
		txtIPAddress.setText("localhost/127.0.0.1");
		txtIPAddress.setHorizontalAlignment(SwingConstants.CENTER);
		txtIPAddress.setEditable(false);
		txtIPAddress.setBounds(38, 12, 124, 31);
		getContentPane().add(txtIPAddress);
		txtIPAddress.setColumns(10);

		txtPortAddress = new JTextField();
		txtPortAddress.setEditable(false);
		txtPortAddress.setHorizontalAlignment(SwingConstants.CENTER);
		txtPortAddress.setColumns(10);
		txtPortAddress.setBounds(210, 12, 63, 31);
		getContentPane().add(txtPortAddress);

		lblIp = new JLabel("IP:");
		lblIp.setBounds(12, 20, 66, 15);
		getContentPane().add(lblIp);

		lblPort = new JLabel("PORT:");
		lblPort.setBounds(166, 20, 66, 15);
		getContentPane().add(lblPort);

		online = new JTextArea(10, 10);
		online.setEditable(false);
		online.setColumns(20);
		online.setBounds(380, 89, 191, 256);
		getContentPane().add(online);

		lblDanhSchOnline = new JLabel("Danh sach ket noi");
		lblDanhSchOnline.setHorizontalAlignment(SwingConstants.CENTER);
		lblDanhSchOnline.setFont(new Font("DejaVu Sans Mono", Font.BOLD, 13));
		lblDanhSchOnline.setBounds(385, 71, 186, 15);
		getContentPane().add(lblDanhSchOnline);

		start = new JButton("Start");
		start.addActionListener(this);
		start.setForeground(new Color(240, 255, 255));
		start.setBackground(new Color(0, 191, 255));
		start.setBounds(380, 357, 191, 25);
		getContentPane().add(start);

		JButton btnTime = new JButton("S");
		btnTime.setBackground(new Color(255, 255, 0));
		btnTime.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				if (i%2 == 0) {
					getContentPane().setBackground(new Color(0, 0, 0));
					label.setForeground(new Color(255, 255, 255));
					lblIp.setForeground(new Color(255, 255, 255));
					lblPort.setForeground(new Color(255, 255, 255));
					lblDanhSchOnline.setForeground(new Color(255, 255, 255));
					txtIPAddress.setForeground(new Color(245, 245, 245));
					txtIPAddress.setBackground(new Color(105, 105, 105));
					txtPortAddress.setForeground(new Color(245, 245, 245));
					txtPortAddress.setBackground(new Color(105, 105, 105));
					close.setForeground(new Color(255, 255, 255));
					close.setBackground(new Color(105, 105, 105));
					start.setForeground(new Color(255, 255, 255));
					start.setBackground(new Color(105, 105, 105));
					online.setForeground(new Color(255, 255, 255));
					online.setBackground(new Color(105, 105, 105));
					btnTime.setBackground(new Color(255, 0, 0));
					label_1.setIcon(new ImageIcon("/home/iot/eclipse-workspac/ServerOnly/src/image/lgSang.png"));
					i++;
				} else {
					getContentPane().setBackground(new Color(238, 238, 238));
					label.setForeground(new Color(51, 51, 51));
					lblIp.setForeground(new Color(51, 51, 51));
					lblPort.setForeground(new Color(51, 51, 51));
					lblDanhSchOnline.setForeground(new Color(51, 51, 51));
					txtIPAddress.setForeground(new Color(51, 51, 51));
					txtIPAddress.setBackground(new Color(255, 255, 255));
					txtPortAddress.setForeground(new Color(51, 51, 51));
					txtPortAddress.setBackground(new Color(255, 255, 255));
					close.setForeground(new Color(51, 51, 51));
					close.setBackground(new Color(255, 255, 255));
					start.setForeground(new Color(245, 245, 245));
					start.setBackground(new Color(0, 191, 255));
					online.setForeground(new Color(51, 51, 51));
					online.setBackground(new Color(255, 255, 255));
					btnTime.setBackground(new Color(255, 255, 0));
					label_1.setIcon(new ImageIcon("/home/iot/eclipse-workspac/ServerOnly/src/image/lgToi.png"));
					i++;
				}
			}
		});
		btnTime.setBounds(12, 357, 26, 25);
		getContentPane().add(btnTime);
		
		label_1 = new JLabel("");
		label_1.setIcon(new ImageIcon("/home/iot/eclipse-workspac/ServerOnly/src/image/lgToi.png"));
		label_1.setBounds(433, 8, 150, 51);
		getContentPane().add(label_1);

	}
//ffffffffffffff
// Khoi chay server	
	private void go(int port) {
		try {
			txtPortAddress.setText(Integer.toString(port));
			txtPortAddress.setEditable(false);
			start.setEnabled(false);
			listUser = new Hashtable<String, ThreadSever>();
			server = new ServerSocket(port);
			user.append("[#] Server Chat hoat dong tai \ndia chi: " + txtIPAddress.getText() + ":" + port + "\n");
			while (true) {
				Socket client = server.accept();
				System.out.println("Co 1 thang truy cap , ahihi");
				new ThreadSever(this, client);
			}
		} catch (IOException e) {
			user.append("Khong the khoi dong Server Chat \ntai PORT: " + txtIPAddress.getText() + ":"
					+ Integer.parseInt(txtPortAddress.getText()) + "\n");
		}
	}

	public static void main(String[] args) {
		// new Server();

		new Server().go(9999);

	}

	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == close) {
			System.exit(0);
		}

		// Button Start
//		else if (e.getSource() == start) {
//			if (txtPortAddress.getText().equals("")) {
//				JOptionPane.showMessageDialog(this, "Ban chua nhap PORT !");
//			} else {
//				System.out.println("PORT : " + Integer.parseInt(txtPortAddress.getText()));
//				go(Integer.parseInt(txtPortAddress.getText()));
//			}
//		}

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
