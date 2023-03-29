#include <iostream>
#include <vector>
using namespace std;
void print(vector<int> v){
    cout<<v.size();
    for(int i : v){
        cout<<" " << i;
    }
    cout << endl;
}

int main(){
    int n;
    vector<int>pos,neg,zero;
    cin >> n;
    int enteredNumber;
    while(n--){
        cin >> enteredNumber;
        if(enteredNumber > 0){
            pos.push_back(enteredNumber);
        }
        else if(enteredNumber < 0){
            neg.push_back(enteredNumber);
        }else{
            zero.push_back(enteredNumber);
        }

    }



    if(neg.size()% 2==0){
        zero.push_back(neg.back());
        neg.pop_back();
    }
    if(pos.empty()){
        pos.push_back(neg.back());
        neg.pop_back();
        pos.push_back(neg.back());
        neg.pop_back();
    }

    print(neg);
    print(pos);
    print(zero);
}