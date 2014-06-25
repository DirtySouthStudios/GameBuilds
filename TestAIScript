private Transform player, transform;
        public float overshoot, waitingTime;
        private Vector3 lastPlayerPosition;
        private bool isWaiting;
 
        private void Awake() {
            player = GameObject.FindGameObjectWithTag( "Player" ).transform;
            transform = transform;
 
            lastPlayerPosition = player.position;
        }
 
        private void Update() {
            //Either the players position hasnt changed or we are currently waiting
            if( lastPlayerPosition == player.position || isWaiting ) return;
 
            lastPlayerPosition = player.position;
 
            transform.LookAt( player );
            transform.position +=  ( player.position - transform.position ) + transform.forward*overshoot;
            transform.LookAt( player );
 
            StartCoroutine( Wait());
        }
 
        private IEnumerator Wait() {
            isWaiting = true;
            yield return new WaitForSeconds( waitingTime );
            isWaiting = false;
        }
