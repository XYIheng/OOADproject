from socket import *
import threading

def server(address):
	sock = socket(AF_INET, SOCK_STREAM)
	sock.bind(address)
	sock.listen(1)
	print('server starts!')
	while True:
		client, addr = sock.accept()
		print('Connection from', addr)
		t = threading.Thread(target=handler, args=(client,))
		t.start()

def handler(client):
	while True:
		data = client.recv(10000)
		if not data:
			break
		print(b'server receives:' + data)
		print(client)
	print('Connection closed!')
	client.close()

if __name__ == '__main__':
	server(('127.0.0.1', 6666))


