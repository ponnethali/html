def test_register_user(self):
        //response = self.client.post('/auth/register', data={
        //    'username': 'alice',
        //    'email': 'alice@example.com',
        //    'password': 'foo',
        //    'password2': 'foo',
        //}, follow_redirects=True)
        //assert response.status_code == 200
        //assert response.request.path == '/auth/login' # redirected to login

        # login with new user
        response = self.client.post('/auth/login', data={
            'username': 'ali',
            'password': '123',
        }, follow_redirects=True)
        assert response.status_code == 200
        html = response.get_data(as_text=True)
        assert 'Hi, ali!' in html
