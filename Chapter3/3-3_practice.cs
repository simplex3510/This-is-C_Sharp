// 3. 값 형식과 참조 형식의 차이는 무엇인가.

/*
리터럴: 고정값을 나타내는 표기법

값 형식: 변수가 값을 담는 데이터 형식
참조 형식: 값이 있는 곳의 위치(주소)를 담는 데이터 형식

값 형식의 경우, 메모리 구조에서 '스택' 영역에 할당되어 사용되지만
참조 형식의 경우, 메모리 구조에서 '힙' 영역에 할당되어 사용된다.

'스택' 영역은 스택 자료구조로 이루어진 메모리 공간이며, 해당 코드 블럭이 끝나는 지점에서 모두 LIFO 방식으로 자동으로 삭제된다.
'힙' 영역은 스스로 데이터를 제거하는 메커니즘이 없어 CLR의 '가비지 컬렉터'가 사용하지 않는 메모리 공간(객체)을 자동으로 수거한다.

'가비지 컬렉터'는 힙 영역의 데이터를 가리키는 스택 영역의 포인터가 없으면 쓰레기로 간주하여 메모리를 수거한다.

'스택' 영역은 코드 블럭이 끝나는 지점에서 데이터가 삭제되지만,
'힙' 영역은 코드 블럭이 끝나는 지점과 상관 없이 데이터가 유지된다.

'스택' 영역에는 주로 데이터가 저장된 위치(주소)가 저장되어 사용되며,
'힙' 영역에서는 주로 데이터가 저장된다.
*/